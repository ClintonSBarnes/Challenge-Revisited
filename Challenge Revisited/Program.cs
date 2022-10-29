using Challenge_Revisited;


//main program runs here

GameSystem gameSystem = new GameSystem();
InputManager inputManager = new InputManager();
Menu menu = new Menu();
Player player = new Player();

//beginning of game
gameSystem.board.BoardBuilderAndValidation();


//player movement - this will need to be called on every turn. 

while (gameSystem.GetPlaying())
{
    menu.NextMovePrompt(); //prompts player action for this move.

    player.InputIntake(gameSystem.GetBoundaryCheck()); //determines if the player is currently limited by a boundary.






    //Run each after each move.
    menu.RetrievePlayerPosition(player.GetPlayerPosition()); //saves player's current position into memory.
    gameSystem.SetPlayerPosition(player.GetPlayerPosition());
    gameSystem.MoveUpdate(); //saves boundary check into memory. 
    player.SetBoundaryCheck(gameSystem.GetBoundaryCheck());


}





