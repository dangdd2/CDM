namespace Tmag.ConsumerDataModelApi.Helper
{
    public static class ValidationMessages
    {
        //Consumer Controller
        public static string ConsumerIdIsNotValid = "ConsumerId is not valid data type. Please try again.";
        public static string RegionIdIsNotValid = "RegionId is not valid data type. Please try again.";
        public static string SystemIdIsNotValid = "SystemId is not valid data type. Please try again.";
        public static string ConsumerNotFound = "Consumer not found.";
        public static string EmailRequired = "Email must be provided.";
        public static string ConsumerIdRequired = "ConsumerId must be provided.";
        public static string RegionIdRequired = "RegionId must be provided.";
        public static string ConsumerNoNeedToProvided = "You provided a consumer ID. Use /update.";
        public static string CountryRequired = "Unable to update customer record! Country field is required.";
        public static string ConsumerFoundButEmailIsNotMatch = "Consumer found but emails don't match. Updating email is not allowed.";
        public static string EmailOrConsumerIdRequired = "Email or ConsumerID is required.";
        public static string InvalidEmailFormat = "Invalid email format.";
        public static string ConsumerAlreadyExists = "Consumer already exists with the provided email.";
        public static string SystemIdRequired = "SystemId must be provided.";
        /* generic error message for errors for corner cases */
        public static string GenericServerError = "A server error occurred. Please contact the administrator.";
    }

}
