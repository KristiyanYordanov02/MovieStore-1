using FluentValidation;
using FluentValidation.AspNetCore;
using MovieStore.Models.Request;

namespace MovieStore.Validation
{
    public class ddMovieRequestValidator : AbstractValidator<AddMovieRequest>
    {
        public ddMovieRequestValidator()
        {
            RuleFor(x => x.Title)
            .NotEmpty()
            .NotNull()
            .MaximumLength(100)
            .MinimumLength(2);

            RuleFor(x => x.Year)
                .GreaterThan(1900).WithMessage("Year must be greater than 1900")
                .LessThan(2100);
        }
    }
}
