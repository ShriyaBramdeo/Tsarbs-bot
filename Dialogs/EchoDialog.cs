using System;
using System.Threading.Tasks;

using Microsoft.Bot.Connector;
using Microsoft.Bot.Builder.Dialogs;
using System.Net.Http;


namespace Microsoft.Bot.Sample.SimpleEchoBot
{
    [Serializable]
    public class EchoDialog : IDialog<object>
    {
        public async Task StartAsync(IDialogContext context)
        {
            context.Wait(MessageReceivedAsync);
        }

        private async Task MessageReceivedAsync(IDialogContext context, IAwaitable<object> result)

        {

            var activity = await result as Activity;



            // calculate something for us to return 

            int length = (activity.Text ?? string.Empty).Length;



            // return our reply to the user 



            //test 

            if (activity.Text.Contains("technology"))

            {

                await context.PostAsync("Refer C# corner website for tecnology http://www.c-sharpcorner.com/");

            }

            else if (activity.Text.Contains("morning"))

            {

                await context.PostAsync("Hello !! Good Morning , Have a nice Day");

            }

            //test 

            else if (activity.Text.Contains("night"))

            {

                await context.PostAsync(" Good night and Sweetest Dreams with Bot Application ");

            }

            else if (activity.Text.Contains("date"))

            {

                await context.PostAsync(DateTime.Now.ToString());

            }
            else if (activity.Text.Contains("What Kind"))
            {
                await context.PostAsync("Lukker and you");
            }
            else if (activity.Text.Contains("help"))
            {
                await context.PostAsync("Call 911");
            }
            else

            {

                await context.PostAsync($"You sent {activity.Text} which was {length} characters");

            }

            



            context.Wait(MessageReceivedAsync);

        }
    }
    }
}