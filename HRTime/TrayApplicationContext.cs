namespace HRTime
{
    public class TrayApplicationContext : ApplicationContext
    {
        public TrayApplicationContext()
        {
            // Use the Singleton instance to manage the tray icon
            TrayApplicationManager manager = TrayApplicationManager.Instance;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                // Dispose of TrayApplicationManager
                TrayApplicationManager.Instance.Dispose();
            }

            base.Dispose(disposing);
        }
    }
}
