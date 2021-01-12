namespace FacebookApp
{
    using FacebookWrapper;
    using FacebookWrapper.ObjectModel;

    public class AppUser
    {
        private readonly string[] r_Permissions =
            {
            "public_profile",
            "user_birthday",
            "user_location",
            "user_photos",
            "user_gender",
            "email",
            "user_posts",
            };

        public AppUser(string i_AppId)
        {
            AppId = i_AppId;
            logIn();
        }

        public User LoggedInUser { get; set; }

        public LoginResult LoginResult { get; set; }

        private string AppId { get; set; }

        private void logIn()
        {
            if (LoginResult == null)
            {
                LoginResult = FacebookService.Login(AppId, r_Permissions);
            }
        }
    }
}