﻿namespace Inventory.Models;
public class UserProfile
{
    public int UserProfileId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string ConfirmPassword { get; set; }
    public string OldPassword { get; set; }
    public string ProfilePicture { get; set; }
    public string AppUserId { get; set; }
}
