using EPiServer.Core;

namespace AlloyWithCDN.Models.Pages
{
    public interface IHasRelatedContent
    {
        ContentArea RelatedContentArea { get; }
    }
}
