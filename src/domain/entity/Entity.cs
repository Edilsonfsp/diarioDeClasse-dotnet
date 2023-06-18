namespace diarioClasse.domain.entity;

public abstract class Entity
{
  public Guid Id { get; set; }
  public string Name { get; set; }
  public string Description { get; set; }
  public String CreatedBy { get; set; }
  public String EditedBy { get; set; }
  public DateTime CreatedOn { get; set; }
  public DateTime EditedOn { get; set; }
  public Boolean IsActive { get; set; }
  public Entity()
  {
    this.Id = Guid.NewGuid();
    this.IsActive = true;
    this.CreatedOn = DateTime.Now;
    this.EditedOn = DateTime.Now;
  }
}
