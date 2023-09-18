using MovieManagement.DataAccess;
using MovieManagement.DataAccess.UnitOfWork;
using MovieManagement.Model;

namespace MovieManagement.Service.DirectorServices
{
    public class DirectorController : DirectorMenu
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly AppDbContext context;
        public DirectorController(IUnitOfWork unitOfWork, AppDbContext _context)
        {
            _unitOfWork = unitOfWork;
            context = _context;
        }

        private void AddDirector()
        {
            Director director = new Director();
            var addDirector = base.AddNewMenu(director);
            _unitOfWork.DirectorRepository.Add(addDirector);
            _unitOfWork.SaveChange();
        }

        private void UpdateDirector()
        {
            int id = base.FindId();
            var director = GetById(id);
            var update = base.UpdateMenu(director);
            _unitOfWork.DirectorRepository.Edit(update);
            _unitOfWork.SaveChange();
        }

        private void GetAllDirector()
        {
            var list = _unitOfWork.DirectorRepository.GetAll();
            foreach (var director in list)
            {
                Console.WriteLine($"{director.Id} - {director.Name}\n");
            }
        }

        private void DeleteDirector()
        {
            int id = base.FindId();
            var director = GetById(id);
            _unitOfWork.DirectorRepository.Delete(director);
            _unitOfWork.SaveChange();
        }

        private Director GetById(int id)
        {
            var director = _unitOfWork.DirectorRepository.GetById(id);
            return director;
        }

        private void ShowDirectorById()
        {
            int id = base.FindId();
            var director = GetById(id);
            Console.WriteLine($"{director.Id} - {director.Name}");
        }

        public void DirectorManagement()
        {
            int choice = 0;
            do
            {
                try
                {
                    base.DirectorMainMenu();
                    choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            GetAllDirector();
                            break;
                        case 2:
                            ShowDirectorById();
                            break;
                        case 3:
                            AddDirector();
                            break;
                        case 4:
                            UpdateDirector();
                            break;
                        case 5:
                            DeleteDirector();
                            break;
                        case 6:
                            break;
                        default:
                            throw new Exception("Please choose from 1 to 6");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            } while (choice != 6);
        }
    }
}

