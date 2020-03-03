using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using Tmag.Common.Repositories;
using Tmag.ConsumerData.Models;

namespace Tmag.SugarOneOffDataTransferJob
{
    public class StaticTableHelper
    {
        private readonly IRepository _repository;
        private readonly ILogger<Consumer> _logger;

        public StaticTableHelper(IRepository repository, ILogger<Consumer> logger)
        {
            _repository = repository;
            _logger = logger;
        }

        private List<ClubShaftLength> ClubShaftLengths = new List<ClubShaftLength>();
        public Guid GetChaftLengthId(string shaftLengthC)
        {
            if (!ClubShaftLengths.Any())
            {
                ClubShaftLengths = _repository.Query<ClubShaftLength>().ToList();
            }
            var clubShaftlength = ClubShaftLengths.FirstOrDefault(x => x.Value.ToLower() == shaftLengthC.ToLower());
            if (clubShaftlength == null)
            {
                clubShaftlength = new ClubShaftLength()
                {
                    Id = Guid.NewGuid(),
                    Value = shaftLengthC,
                    Created = DateTime.UtcNow
                };
                ClubShaftLengths.Add(clubShaftlength);
                _repository.Save(clubShaftlength);                
            }

            if (clubShaftlength.Id != null) return clubShaftlength.Id.Value;
            return Guid.Empty;
        }

        private List<Model> Models = new List<Model>();
        public Guid GetModelId(string modelName)
        {
            if (!Models.Any())
            {
                Models = _repository.Query<Model>().ToList();
            }
            var model = Models.FirstOrDefault(x => x.Name.ToLower() == modelName.ToLower());
            if (model == null)
            {
                model = new Model
                {
                    Name = modelName,
                    Created = DateTime.UtcNow
                };
                _repository.Save(model);
                Models.Add(model);
            }

            if (model.Id != null) return model.Id.Value;
            return Guid.Empty;
        }

        private List<Brand> Brands = new List<Brand>();
        public Guid? GetBrandId(string brandName)
        {
            if (!Brands.Any())
            {
                Brands = _repository.Query<Brand>().ToList();
            }
            var brand = Brands.FirstOrDefault(x => x.Name.ToLower() == brandName.ToLower());
            if (brand == null)
            {
                brand = new Brand
                {
                    Name = brandName,
                    Created = DateTime.UtcNow
                };
                _repository.Save(brand);
                Brands.Add(brand);
            }
            return brand.Id;
        }

        private List<ClubCategory> ClubCategorys = new List<ClubCategory>();
        public Guid GetCategoryId(string categoryName)
        {
            if (!ClubCategorys.Any())
            {
                ClubCategorys = _repository.Query<ClubCategory>().ToList();
            }
            var fixedName = categoryName.EndsWith("s") ? categoryName.Remove(categoryName.Length - 1) : categoryName;
            var category = ClubCategorys.FirstOrDefault(x => x.Name.ToLower() == fixedName.ToLower());
            if (category == null)
            {
                category = new ClubCategory()
                {
                    Name = fixedName,
                    Created = DateTime.UtcNow
                };
                _repository.Save(category);
                ClubCategorys.Add(category);
            }

            if (category.Id != null) return category.Id.Value;
            return Guid.Empty;
        }

        private List<ClubLie> ClubLies = new List<ClubLie>();
        public Guid GetLieId(string faceLieAdjustmentC)
        {
            if (!ClubLies.Any())
            {
                ClubLies = _repository.Query<ClubLie>().ToList();
            }
            var lie = ClubLies.FirstOrDefault(x => x.Value.ToLower() == faceLieAdjustmentC.ToLower());
            if (lie == null)
            {
                lie = new ClubLie
                {
                    Value = faceLieAdjustmentC,
                    Created = DateTime.UtcNow
                };
                _repository.Save(lie);
                ClubLies.Add(lie);
            }

            if (lie.Id != null) return lie.Id.Value;
            return Guid.Empty;
        }

        private List<ClubLoft> ClubLofts = new List<ClubLoft>();
        public Guid GetLoftId(string loftC)
        {
            if (!ClubLofts.Any())
            {
                ClubLofts = _repository.Query<ClubLoft>().ToList();
            }
            var loft = ClubLofts.FirstOrDefault(x => x.Value.ToLower() == loftC.ToLower());
            if (loft == null)
            {
                loft = new ClubLoft()
                {
                    Value = loftC,
                    Created = DateTime.UtcNow
                };
                _repository.Save(loft);
                ClubLofts.Add(loft);
            }

            if (loft.Id != null) return loft.Id.Value;
            return Guid.Empty;
        }

        private List<ClubShaftFlex> ClubShaftFlexs = new List<ClubShaftFlex>();
        public Guid GetFlexId(string flexC)
        {
            if (!ClubShaftFlexs.Any())
            {
                ClubShaftFlexs = _repository.Query<ClubShaftFlex>().ToList();
            }
            var flex = ClubShaftFlexs.FirstOrDefault(x => x.Value.ToLower() == flexC.ToLower());
            if(flex == null)
            {
                flex = new ClubShaftFlex()
                {
                    Value = flexC,
                    Created = DateTime.UtcNow
                };
                _repository.Save(flex);
                ClubShaftFlexs.Add(flex);
            }

            if (flex.Id != null) return flex.Id.Value;
            return Guid.Empty;
        }
        private List<ClubHand> _clubHands = new List<ClubHand>();
        public Guid GetClubHandId(string hand)
        {
            if (!_clubHands.Any())
            {
                _clubHands = _repository.Query<ClubHand>().ToList();
            }
            
            var clubHand = _clubHands.FirstOrDefault(x => x.Description.ToLower() == hand.ToLower());
            if (clubHand == null)
            {
                clubHand = new ClubHand()
                {
                    Description = hand,
                    Created = DateTime.UtcNow
                };
                _repository.Save(clubHand);
                _clubHands.Add(clubHand);
            }

            if (clubHand.Id != null) return clubHand.Id.Value;
            return Guid.Empty;
        }
        private List<HandicapRange> _handicapRanges = new List<HandicapRange>();
        public Guid GetRangeId(string hand)
        {
            if (!_handicapRanges.Any())
            {
                _handicapRanges = _repository.Query<HandicapRange>().ToList();
            }
            var clubHand = _handicapRanges.FirstOrDefault(x => x.Range.ToLower() == hand.ToLower());
            if (clubHand == null)
            {
                clubHand = new HandicapRange()
                {
                    Range = hand,
                    Created = DateTime.UtcNow
                };
                _repository.Save(clubHand);
                _handicapRanges.Add(clubHand);
            }

            if (clubHand.Id != null) return clubHand.Id.Value;
            return Guid.Empty;
        }

        private List<ClubCategoryType> ClubCategoryTypes = new List<ClubCategoryType>();
        internal Guid? GetClubCategoryTypeId(string headLoftC)
        {
            if (!ClubCategoryTypes.Any())
            {
                ClubCategoryTypes = _repository.Query<ClubCategoryType>().ToList();
            }
            var clubHand = ClubCategoryTypes.FirstOrDefault(x => x.Type.ToLower() == headLoftC.ToLower());
            return clubHand?.Id;
        }
    }
}
