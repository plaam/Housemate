﻿using FluentValidation;
using Housemate.Contracts.Requests.StudentRequests;

namespace Housemate.Application.Validators.StudentValidators;

public sealed class UpdateStudentRequestValidator : AbstractValidator<UpdateStudentRequest>
{
    public UpdateStudentRequestValidator()
    {
        RuleFor(request => request.Name)
            .NotEmpty();
        
        RuleFor(request => request.LastName)
            .NotEmpty();

        RuleFor(request => request.Email)
            .NotEmpty()
            .EmailAddress();
        
        RuleFor(request => request.Birthdate)
            .NotEmpty()
            .LessThan(DateOnly.FromDateTime(DateTime.UtcNow));

        RuleFor(request => request.Password)
            .NotEmpty()
            .Matches(@"^(?=[^a-z]*[a-z])(?=[^A-Z]*[A-Z])(?=\D*\d)(?=[^!#%]*[!#%])[A-Za-z0-9!#%]{6,32}$");

        RuleForEach(request => request.HousingTasks)
            .NotEmpty();
    }
}