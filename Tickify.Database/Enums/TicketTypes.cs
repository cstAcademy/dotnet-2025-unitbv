namespace Tickify.Database.Entities;

[Flags]
public enum TicketTypes
{
    None = 0,

    General          = 1,
    EarlyBird        = 2,
    BackstageAccess  = 4,
    UnlimitedDrinks  = 8,
    Adult            = 16,
    Child            = 32,
}