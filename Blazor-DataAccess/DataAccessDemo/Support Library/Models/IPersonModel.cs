﻿namespace Support_Library.Models
{
    public interface IPersonModel
    {
        DateTime DateOfBirth { get; set; }
        string FirstName { get; set; }
        int Id { get; set; }
        string LastName { get; set; }
    }
}