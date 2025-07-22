using System.ComponentModel;

namespace GARequestCenterAPI.Models
{
    public class PdfModel
    {
        public string html { get; set; }

        private bool _landscape = false;
        [DefaultValue(false)]
        public bool landscape
        {
            get
            {
                return _landscape;
            }
            set
            {
                _landscape = value;
            }
        }

        private bool _isCustomFont = false;
        [DefaultValue(false)]
        public bool isCustomFont
        {
            get
            {
                return _isCustomFont;
            }
            set
            {
                _isCustomFont = value;
            }
        }
    }
}
