using Microsoft.AspNetCore.Components;

namespace BlazorApp.Pages
{
    public class CounterBase : ComponentBase
    {
        protected int currentCount = 0;

        protected void IncrementCount()
        {
            currentCount+=2;
        }
    }    
}

