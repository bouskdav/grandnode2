﻿using DiscountRules.Standard.Providers;
using Grand.Business.Core.Interfaces.Catalog.Discounts;
using System.Reflection;

namespace DiscountRules.Standard
{
    public class DiscountProvider : IDiscountProvider
    {
        private readonly CustomerGroupDiscountRule _customerGroupDiscountRequirementRule;
        private readonly HadSpentAmountDiscountRule _hadSpentAmountDiscountRequirementRule;
        private readonly HasAllProductsDiscountRule _hasAllProductsDiscountRequirementRule;
        private readonly HasOneProductDiscountRule _hasOneProductDiscountRequirementRule;
        private readonly ShoppingCartDiscountRule _shoppingCartDiscountRequirementRule;
        private readonly IEnumerable<IDiscountRule> _discountRules;

        public DiscountProvider(
            CustomerGroupDiscountRule customerGroupDiscountRequirementRule,
            HadSpentAmountDiscountRule hadSpentAmountDiscountRequirementRule,
            HasAllProductsDiscountRule hasAllProductsDiscountRequirementRule,
            HasOneProductDiscountRule hasOneProductDiscountRequirementRule,
            ShoppingCartDiscountRule shoppingCartDiscountRequirementRule,
            IEnumerable<IDiscountRule> discountRules)
        {
            _customerGroupDiscountRequirementRule = customerGroupDiscountRequirementRule;
            _hadSpentAmountDiscountRequirementRule = hadSpentAmountDiscountRequirementRule;
            _hasAllProductsDiscountRequirementRule = hasAllProductsDiscountRequirementRule;
            _hasOneProductDiscountRequirementRule = hasOneProductDiscountRequirementRule;
            _shoppingCartDiscountRequirementRule = shoppingCartDiscountRequirementRule;
            _discountRules = discountRules;
        }


        public string ConfigurationUrl => "";

        public string SystemName => "DiscountRules.Standard";

        public string FriendlyName => "Standard discount requirements";

        public int Priority => 0;

        public IList<string> LimitedToStores => new List<string>();

        public IList<string> LimitedToGroups => new List<string>();

        public IList<IDiscountRule> GetRequirementRules()
        {
            var rules = new List<IDiscountRule>
            {
                _customerGroupDiscountRequirementRule,
                _hadSpentAmountDiscountRequirementRule,
                _hasAllProductsDiscountRequirementRule,
                _hasOneProductDiscountRequirementRule,
                _shoppingCartDiscountRequirementRule
            };

            rules.AddRange(_discountRules);

            return rules;
        }
    }
}
