using FluentAssertions;
using Stripe.Tests.Xunit;
using Xunit;

namespace Stripe.Tests.XUnit
{
    public class when_listing_balance_transactions
    { 
        public when_listing_balance_transactions()
        {
            // todo: minimize this happening every time. it only needs 4 charges present to test the list

            Cache.GetStripeCharge(Cache.ApiKey);
            Cache.GetStripeCharge(Cache.ApiKey);
            Cache.GetStripeCharge(Cache.ApiKey);
            Cache.GetStripeCharge(Cache.ApiKey);
        }
    }
}
