namespace FarmApp.Api.Dtos
{
    public record class UpdateMachineDto(Guid Id, string Mark, string Seria, decimal Milage);
}
