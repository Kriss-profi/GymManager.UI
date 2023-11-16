namespace GymManager.Domain.Entities;

public class Settings
{
    public int Id { get; set; }
    public string Description { get; set; }
    public int Order {  get; set; }

    public ICollection<SettingsPosition> Position { get; set; } = new HashSet<SettingsPosition>();
}
