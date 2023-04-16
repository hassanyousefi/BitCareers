namespace BitCareers.Web.Pages
{
    public partial class Main
    {
        private BitCarousel? carousel;
        private void GoNext() => carousel?.GoNext();
    }
}
