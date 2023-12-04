using Microsoft.AspNetCore.Identity.Data;

namespace CleanArchitectureDemo.Application.Interfaces;

public interface IEmailService
{
  Task SendAsync(ResendConfirmationEmailRequest request);
}
