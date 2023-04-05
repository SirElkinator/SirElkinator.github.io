namespace MyPortfolio.Pages
{
    public partial class NavBar
    {
        private int _value;

        [Parameter]
        public int siteIndex
        {
            get => _value;
            set
            {
                if (_value == value) return;
                _value = value;
                siteIndexChanged.InvokeAsync(value);
            }
        }

        [Parameter]
        public EventCallback<int> siteIndexChanged { get; set; }

        public void AboutMe()
        {
            siteIndex = 1;
        }

        public void Accomplishments()
        {
            siteIndex = 2;
        }

        public void Experience()
        {
            siteIndex = 3;
        }

        public void ContactMe()
        {
            siteIndex = 4;
        }

        public async Task Resume() {
            await JS.InvokeVoidAsync("downloadFromUrl", "/docs/CSResume.docx", "CSResume.docx").ConfigureAwait(false);
        }

        public async Task GitHub()
        {
            await JS.InvokeVoidAsync("open", "https://github.com/SirElkinator", "_blank").ConfigureAwait(false);
        }

        public async Task LinkedIn()
        {
            await JS.InvokeVoidAsync("open", "https://www.linkedin.com/in/chase-sparks-40805b12b/", "_blank").ConfigureAwait(false);
        }

        public async Task MyBlog()
        {
            await JS.InvokeVoidAsync("open", "https://chasesparks97.blogspot.com/", "_blank").ConfigureAwait(false);
        }
    }
}