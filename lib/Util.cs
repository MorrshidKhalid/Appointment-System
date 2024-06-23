using System.Windows.Forms;

namespace ClinicPresentationLayerDesktop.lib
{
    public static class Util
    {
        private static readonly string NOT_FOUND_MESSAGE = "Not Found!";
        public static void DisplayNotFoundMsg()
        {
            MessageBox.Show(NOT_FOUND_MESSAGE);
        }        
    }

}
