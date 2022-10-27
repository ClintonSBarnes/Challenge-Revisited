using Challenge_Revisited;


//main program runs here

GameSystem gameSystem = new GameSystem();
InputManager inputManager = new InputManager();

//beginning of game
gameSystem.board.BoardBuilderAndValidation();


//player movement - this will need to be called on every turn. 
inputManager.InputIntake(gameSystem.GetBoundaryCheck());








