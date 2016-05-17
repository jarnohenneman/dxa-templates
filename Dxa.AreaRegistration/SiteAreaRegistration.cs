using Sdl.Web.Mvc.Configuration;

namespace $rootnamespace$
{
    public class $safeitemrootname$ : BaseAreaRegistration
    {
        /// <summary>
        /// AreaRegistration for custom Site/Module: "Site".
        /// </summary>
        public override string AreaName
        {
            get
            {
                return "Site";
            }
        }

        protected override void RegisterAllViewModels()
        {
            // Entity Views
            //RegisterViewModel("DxaView", typeof(DxaModel));

            // Page Views
            //RegisterViewModel("DxaView", typeof(PageModel), "Page");
        }
    }
}
