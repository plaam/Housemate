﻿namespace Housemate.Contracts.Responses.StudentResponses;

public sealed class StudentResponse
{
    public required string Id { get; init; }
    
    public required string Name { get; init; }
    
    public required string LastName { get; init; }
    
    public required string Email { get; init; }
    
    public required string Password { get; init; }
    
    public required DateOnly Birthdate { get; init; }
}