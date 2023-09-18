using MovieManagement.DataAccess.UnitOfWork;
using MovieManagement.Helper;
using MovieManagement.Service.DirectorServices;
using MovieManagement.Service.MainMenu;
using MovieManagement.Service.MovieServices;

var context = Helper.GetContext();
IUnitOfWork unitOfWork = new UnitOfWork(context);
DirectorController directorController = new DirectorController(unitOfWork, context);
MovieController movieController = new MovieController(unitOfWork, context);
int mainChoice = 0;
do
{
	try
	{
        MainMenu.Menu();
        mainChoice = int.Parse(Console.ReadLine());
        switch (mainChoice)
        {
            case 1:
                directorController.DirectorManagement();
                break;
            case 2:
                movieController.MovieManagement();
                break;
            case 3:
                Console.WriteLine("Bye bye !");
                Environment.Exit(0);
                break;
            default:
                throw new Exception("Please choose from 1 to 3");
        }
    }
	catch (Exception ex)
	{
        Console.WriteLine(ex.Message);
    }
} while (mainChoice != 3);
