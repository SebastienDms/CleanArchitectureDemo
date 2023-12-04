using FluentValidation;

namespace CleanArchitectureDemo.Application.Features.Players.Queries.GetPlayersWithPagination;

public class GetPlayersWithPaginationValidator : AbstractValidator<GetPlayersWithPaginationQuery>
{
  public GetPlayersWithPaginationValidator()
  {
    RuleFor(p => p.PageNumber)
      .GreaterThanOrEqualTo(1)
      .WithMessage("PageNumber should be greater than or equal to 1");

    RuleFor(p => p.PageSize)
      .GreaterThanOrEqualTo(1)
      .WithMessage("PageSize should be greater than or equal to 1");
  }
}