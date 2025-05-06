namespace E_CommerceProject.ViewModel
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "*")]
        public string Email { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}
