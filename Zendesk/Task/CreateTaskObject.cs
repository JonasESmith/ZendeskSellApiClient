namespace Zendesk.Task
{
  /// <summary>
  /// A simple Task Object that will not contain a Task_Id or other information that would cause the Post methods to throw an error.
  /// </summary>
  public class CreateTaskObject
  {
    public CreateTaskObject()
    {
      data = new CreateTaskData();
      meta = new CreateTaskMeta();
    }
    public CreateTaskData data { get; set; }
    public CreateTaskMeta meta { get; set; }
  }

  public class CreateTaskData
  {
    public string resource_type { get; set; }
    public int    resource_id   { get; set; }
    public int    owner_id      { get; set; }
    public string due_date      { get; set; }
    public string remind_at     { get; set; }
    public string content       { get; set; }
  }

  public class CreateTaskMeta
  {
    public string type { get; set; }
  }
}
