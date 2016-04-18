using Microsoft.Azure.Mobile.Server;

namespace xamarin_evolve_demoService.DataObjects
{
    public class TodoItem : EntityData
    {
        public string Text { get; set; }

        public bool Complete { get; set; }
    }
}