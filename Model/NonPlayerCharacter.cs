namespace GolbinsAndGui.model
{
    internal class NonPlayerCharacter
    {
        public Dialogue dialogue { get; set; }

        public Response setupResponse(int chat)
        {
            dialogue = new Dialogue();
            switch (chat)
            {
                case 0:
                    Response endresponse = new Response();
                    endresponse.responseText = "";
                    endresponse.dialogueOptions = new Dictionary<string, Response>();
                    // responses
                    // violence start response

                    Response response22 = new Response();
                    response22.responseText = "No harm in being curious. If you change your mind, find me at midnight near the town well. There's more to this amulet than meets the eye.";
                    response22.dialogueOptions = new Dictionary<string, Response>();
                    response22.dialogueOptions.Add("Maybe I will. Thanks for the information.", endresponse);
                    response22.dialogueOptions.Add("I doubt I'll change my mind, but I appreciate your willingness to share.", endresponse);

                    Response response21 = new Response();
                    response21.responseText = "The amulet is said to have the power to reveal hidden truths. If you're willing to help me uncover its secrets, I'm willing to share what I know. What do you say?";
                    response21.dialogueOptions = new Dictionary<string, Response>();
                    response21.dialogueOptions.Add("That sounds intriguing. Let's meet at midnight near the town's ancient well and unlock its secrets together.", endresponse);
                    response21.dialogueOptions.Add("I appreciate the offer, but I'll pass. I have other matters to attend to.", endresponse);

                    Response response2 = new Response();
                    response2.responseText = "This amulet has a long and mysterious history. It was passed down through generations in my family. Legends say it holds a connection to a hidden realm. What do you know of such things?";
                    response2.dialogueOptions = new Dictionary<string, Response>();
                    response2.dialogueOptions.Add("I'm more interested in the magical properties of that amulet. Could you share some details about its powers?", response21);
                    response2.dialogueOptions.Add("I'm not particularly interested in magical artifacts. I was just curious.", response22);

                    Response response12 = new Response();
                    response12.responseText = "No worries, not everyone is cut out for such endeavors. If you ever change your mind, find me near the town well at midnight. There might be something else you'd find interesting.";
                    response12.dialogueOptions = new Dictionary<string, Response>();
                    response12.dialogueOptions.Add("I'll keep that in mind. Perhaps I'll join you later.", endresponse);
                    response12.dialogueOptions.Add("Thanks, but I'll pass. Good luck with your search.", endresponse);

                    Response response1112 = new Response();
                    response1112.responseText = "The temple is shrouded in mystery. Some believe it's a place of great power, while others fear it harbors dark forces. The portal, if it exists, is said to lead to a realm untouched by time. Many have sought it, but few have returned.";
                    response1112.dialogueOptions = new Dictionary<string, Response>();
                    response1112.dialogueOptions.Add("A realm untouched by time? That's quite the legend.", endresponse);
                    response1112.dialogueOptions.Add("Dark forces, you say? Sounds like a risky endeavor.", endresponse);

                    Response response1111 = new Response();
                    response1111.responseText = "The refugees were skilled craftsmen and healers. They brought knowledge and culture that shaped our town. As for the forgotten war, it was a conflict between realms that our ancestors wished to leave behind. The temple was their sanctuary.";
                    response1111.dialogueOptions = new Dictionary<string, Response>();
                    response1111.dialogueOptions.Add("Fascinating, bye", endresponse);
                    response1111.dialogueOptions.Add("hah lol", endresponse);


                    // initiate combat
                    Response response111 = new Response();
                    response111.responseText = "The artifact is said to be a key to an ancient temple in the nearby forest. Some claim it opens a portal to another realm. Would you believe our town was founded by refugees from that realm, seeking refuge from a forgotten war?";
                    response111.dialogueOptions = new Dictionary<string, Response>();
                    response111.dialogueOptions.Add("Tell me more about the refugees and the forgotten war.How did they come to settle in this town ?", response1111);
                    response111.dialogueOptions.Add("Interesting, but tell me more about this ancient temple. What kind of portal are we talking about?", response1112);

                    // romance continuation
                    Response response11 = new Response();
                    response11.responseText = "The artifact is said to be a key to an ancient temple in the nearby forest. Some claim it opens a portal to another realm. Would you believe our town was founded by refugees from that realm, seeking refuge from a forgotten war?";
                    response11.dialogueOptions = new Dictionary<string, Response>();
                    response11.dialogueOptions.Add("That's fascinating! I'd love to hear more about the town's history.", response111);
                    response11.dialogueOptions.Add("Interesting, but I'm not much of a history buff. Anything else you can share?", response12);
                    // romance response
                    Response response1 = new Response();
                    response1.responseText = "Ah, greetings, traveler. I seek information about a local artifact rumored to be hidden in this town. Have you heard anything unusual lately?";
                    response1.dialogueOptions = new Dictionary<string, Response>();
                    response1.dialogueOptions.Add("I'm intrigued by your quest. I haven't heard anything about a hidden artifact, but I'd be willing to help. What can you tell me about it?", response11);
                    response1.dialogueOptions.Add("I'm sorry, but I'm not interested in quests right now. Good luck on your search.", response12);

                    // dialogue start response
                    Response startOfDialogue = new Response();
                    startOfDialogue.responseText = "";
                    startOfDialogue.dialogueOptions = new Dictionary<string, Response>();
                    startOfDialogue.dialogueOptions.Add("Greetings, stranger. What brings you to this town square?", response1);
                    startOfDialogue.dialogueOptions.Add("That amulet looks interesting. Where did you get it?", response2);

                    dialogue.dialogueStart = startOfDialogue;
                    break;
                case 1:
                    // Responses
                    Response endResponse = new Response();
                    endResponse.responseText = "";
                    endResponse.dialogueOptions = new Dictionary<string, Response>();

                    // Option 1.1
                    Response sresponse21 = new Response();
                    sresponse21.responseText = "Ah, you have the look of an adventurer about you. I recently discovered a mysterious artifact in the nearby cave. Would you be interested in exploring it with me?";
                    sresponse21.dialogueOptions = new Dictionary<string, Response>();
                    sresponse21.dialogueOptions.Add("Absolutely! I'm always up for an adventure. Tell me more about the artifact.", endResponse);
                    sresponse21.dialogueOptions.Add("I appreciate the offer, but I have other matters to attend to right now. Maybe another time.", endResponse);

                    // Option 1
                    Response sresponse1 = new Response();
                    sresponse1.responseText = "Greetings, traveler! I've heard tales of your exploits. What brings you to our humble town?";
                    sresponse1.dialogueOptions = new Dictionary<string, Response>();
                    sresponse1.dialogueOptions.Add("I'm here seeking information about a rumored artifact. Have you heard anything unusual lately?", sresponse21);
                    sresponse1.dialogueOptions.Add("Just passing through. Anything interesting happening in this town?", endResponse);

                    // Option 2.1
                    Response sresponse42 = new Response();
                    sresponse42.responseText = "This artifact is said to have the power to control the elements. I believe it's hidden in the depths of the cave, guarded by ancient magic. Are you up for the challenge?";
                    sresponse42.dialogueOptions = new Dictionary<string, Response>();
                    sresponse42.dialogueOptions.Add("Controlling the elements? Count me in! Let's head to the cave and unravel its mysteries.", endResponse);
                    sresponse42.dialogueOptions.Add("I'm intrigued, but I need more information. What kind of dangers are we talking about?", endResponse);

                    // Option 2
                    Response sresponse2 = new Response();
                    sresponse2.responseText = "I obtained this amulet through my research. Legends say it's tied to an ancient order with the power to control the elements. What do you know of such things?";
                    sresponse2.dialogueOptions = new Dictionary<string, Response>();
                    sresponse2.dialogueOptions.Add("Controlling the elements? That's fascinating. How did you come across this information?", sresponse42);
                    sresponse2.dialogueOptions.Add("I'm not particularly interested in artifacts right now. Thanks for sharing, though.", endResponse);

                    // Dialogue Start Response
                    Response sstartOfDialogue = new Response();
                    sstartOfDialogue.responseText = "";
                    sstartOfDialogue.dialogueOptions = new Dictionary<string, Response>();
                    sstartOfDialogue.dialogueOptions.Add("Greetings, Sylas. What brings you to this part of town?", sresponse1);
                    sstartOfDialogue.dialogueOptions.Add("That amulet you're wearing looks intriguing. Where did you get it?", sresponse2);

                    dialogue.dialogueStart = sstartOfDialogue;
                break;

            }

            // show the player dialogue
            return dialogue.dialogueStart;

            // player has chosen romance
            //currentResponse = currentResponse.dialogueOptions["How've you been?"];
            // show the player the next set of dialogue keys
            //string[] playerOptions = currentResponse.dialogueOptions.Keys.ToArray();
            // the player chooses violence
            //currentResponse = currentResponse.dialogueOptions["SIKE"];
            //playerOptions = currentResponse.dialogueOptions.Keys.ToArray();

            //if (playerOptions.Length == 0)
            //{
            // dialogue has ended
        }
    }
}
