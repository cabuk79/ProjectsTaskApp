using KanBanTrials.Models;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace KanBanTrials.Data
{
    public class Json
    {
        public void SeralizeAndSaveFileList(List<TaskItem> tasks, string fileLoc, bool overwriteDataOrAdd)
        {
            var filesJson = JsonSerializer.Serialize(tasks);

            if(overwriteDataOrAdd == true)
            {
                File.WriteAllText(fileLoc, filesJson);           
            }
            else
            {
                List<TaskItem> completedTasks = Deseralize(fileLoc);
                foreach(var task in tasks)
                {
                    //if(task.Completed == true)
                   // {
                        completedTasks.Add(task);
                    //}
                }
                var completedTasksSerJson = JsonSerializer.Serialize(completedTasks);
                File.WriteAllText(fileLoc, completedTasksSerJson);
            }
        }

        public void SeralizeAndSaveNoteList(List<TaskNote> taskNotes, string fileLoc)
        {
            var filesJson = JsonSerializer.Serialize(taskNotes);
            
            File.WriteAllText(fileLoc, filesJson);
        }

        public List<TaskItem> Deseralize(string fileLoc)
        {
            var data = File.ReadAllText(fileLoc);
            try
            {
                // Configure JsonSerializer to handle enum names as strings
                var options = new JsonSerializerOptions
                {
                    Converters = { new JsonStringEnumConverter() }
                };

                var jsonData = JsonSerializer.Deserialize<List<TaskItem>>(data, options);

                return jsonData;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }

        }
    }
}
