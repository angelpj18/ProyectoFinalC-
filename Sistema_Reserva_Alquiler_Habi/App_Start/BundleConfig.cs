using System.Web.Optimization;

namespace Sistema_Reserva_Alquiler_Habi
{
    public class BundleConfig
    {
        // Para obtener más información sobre las uniones, visite https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Utilice la versión de desarrollo de Modernizr para desarrollar y obtener información. De este modo, estará
            // para la producción, use la herramienta de compilación disponible en https://modernizr.com para seleccionar solo las pruebas que necesite.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));




            #region Template Desing

            bundles.Add(new ScriptBundle("~/template/js").Include(
                        "~/Scripts/jquery-1.10.2.js",
                        "~/Scripts/bootstrap.min.js",
                        "~/Scripts/jquery.isotope.min.js",
                         "~/Scripts/jquery.prettyPhoto.js",
                         "~/Scripts/custom.js"));

            bundles.Add(new StyleBundle("~/template/css").Include(

                     "~/Content/css/bootstrap.css",
                     "~/Content/css/font-awesome.min.css",
                     "~/Content/css/font-awesome-animation.css",
                     "~/Content/css/prettyPhoto.css",
                       "~/Content/css/style.css"
                     ));

            #endregion


        }
    }
}
