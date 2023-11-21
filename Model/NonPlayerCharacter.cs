using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolbinsAndGui.model
{
    internal class NonPlayerCharacter
    {
        public Dialogue dialogue {  get; set; }

        public Response setupResponse(int chat)
        {
            dialogue = new Dialogue();

            // responses
            // violence start response
            Response violenceStart = new Response();
            violenceStart.responseText = "VIOLENCE!";
            violenceStart.dialogueOptions = new Dictionary<string, Response>();
            // initiate combat

            // romance continuation
            Response romanceContinuation = new Response();
            romanceContinuation.responseText = "AHH";
            romanceContinuation.dialogueOptions = new Dictionary<string, Response>();
            // romance response
            Response romanceStart = new Response();
            romanceStart.responseText = "Oh Obi, I didn't know you cared so...";
            romanceStart.dialogueOptions = new Dictionary<string, Response>();
            romanceStart.dialogueOptions.Add("I've always cared.", romanceContinuation);
            romanceStart.dialogueOptions.Add("SIKE", violenceStart);

            // dialogue start response
            Response startOfDialogue = new Response();
            startOfDialogue.responseText = "General Kenobi!";
            startOfDialogue.dialogueOptions = new Dictionary<string, Response>();
            startOfDialogue.dialogueOptions.Add("How've you been?", romanceStart);
            startOfDialogue.dialogueOptions.Add("Sarcasm", violenceStart);

            dialogue.dialogueStart = startOfDialogue;

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
