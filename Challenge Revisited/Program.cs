using Challenge_Revisited;
// See https://aka.ms/new-console-template for more information

//main program runs here

Board board = new Board();
Menu menu = new Menu();
InputManager inputManager = new InputManager();
Player player = new Player();


//Build initial board posotions and board boundaries for the player. This will prevent the player from moving beyond the boundaries of the board. 
board.BoardBuilder(inputManager.BoardDifficultyValidation());
player.SetPlayerPositionLimit(board.GetBoundaries());


//Updates the player position






