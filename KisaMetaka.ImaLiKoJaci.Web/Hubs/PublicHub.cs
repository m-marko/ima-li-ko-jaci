﻿using KisaMetaka.ImaLiKoJaci.Web.Models.Chat;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace KisaMetaka.ImaLiKoJaci.Web.Hubs
{
    [HubName("publicChat")]
    public class PublicHub : Hub
    {
        public static void ShowNewQuestion(QuestionModel model)
        {
            var hubContext = GlobalHost.ConnectionManager.GetHubContext<PublicHub>();
            hubContext.Clients.All.showNewQuestion(model);
        }

        public static void ShowCorrectAnswer(string winnerDisplayName, string answer)
        {
            var hubContext = GlobalHost.ConnectionManager.GetHubContext<PublicHub>();
            hubContext.Clients.All.showCorrectAnswer(winnerDisplayName, answer);
        }

        public static void SendAnswer(AnswerModel model)
        {
            var hubContext = GlobalHost.ConnectionManager.GetHubContext<PublicHub>();
            hubContext.Clients.All.sendAnswer(model);
        }
    }
}