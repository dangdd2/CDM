﻿using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace Tmag.Common
{
    public class IpHelper
    {
        private readonly HttpContext _httpContextAccessor;

        public IpHelper(HttpContext httpContextAccessor)
        {
            this._httpContextAccessor = httpContextAccessor;
        }
        public string GetRequestIP(bool tryUseXForwardHeader = true)
        {
            string ip = null;

            // todo support new "Forwarded" header (2014) https://en.wikipedia.org/wiki/X-Forwarded-For

            // X-Forwarded-For (csv list):  Using the First entry in the list seems to work
            // for 99% of cases however it has been suggested that a better (although tedious)
            // approach might be to read each IP from right to left and use the first public IP.
            // http://stackoverflow.com/a/43554000/538763
            //
            if (tryUseXForwardHeader)
                ip = SplitCsv(GetHeaderValueAs<string>("X-Forwarded-For")).FirstOrDefault();

            // RemoteIpAddress is always null in DNX RC1 Update1 (bug).
            if (string.IsNullOrWhiteSpace(ip) && _httpContextAccessor?.Connection?.RemoteIpAddress != null)
                ip = _httpContextAccessor.Connection.RemoteIpAddress.ToString();

            if (string.IsNullOrWhiteSpace(ip))
                ip = GetHeaderValueAs<string>("REMOTE_ADDR");

            // _httpContextAccessor.HttpContext?.Request?.Host this is the local host.

            if (string.IsNullOrWhiteSpace(ip))
                throw new Exception("Unable to determine caller's IP.");

            return ip == "::1" ? "127.0.0.1" : ip;
        }

        public bool IsInRange(string startIpAddr, string endIpAddr, string address)
        {
            long ipStart = BitConverter.ToUInt32(IPAddress.Parse(startIpAddr).GetAddressBytes().Reverse().ToArray(), 0);

            long ipEnd = BitConverter.ToUInt32(IPAddress.Parse(endIpAddr).GetAddressBytes().Reverse().ToArray(), 0);

            long ip = BitConverter.ToUInt32(IPAddress.Parse(address).GetAddressBytes().Reverse().ToArray(), 0);

            return ip >= ipStart && ip <= ipEnd; //edited
        }

        public T GetHeaderValueAs<T>(string headerName)
        {
            StringValues values;

            if (_httpContextAccessor?.Request?.Headers?.TryGetValue(headerName, out values) ?? false)
            {
                string rawValues = values.ToString();   // writes out as Csv when there are multiple.

                if (!string.IsNullOrWhiteSpace(rawValues))
                    return (T)Convert.ChangeType(values.ToString(), typeof(T));
            }
            return default(T);
        }

        public static List<string> SplitCsv(string csvList, bool nullOrWhitespaceInputReturnsNull = false)
        {
            if (string.IsNullOrWhiteSpace(csvList))
                return nullOrWhitespaceInputReturnsNull ? null : new List<string>();

            return csvList
                .TrimEnd(',')
                .Split(',')
                .AsEnumerable<string>()
                .Select(s => s.Trim())
                .ToList();
        }
        
    }

}
