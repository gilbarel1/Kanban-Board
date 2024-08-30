// See https://aka.ms/new-console-template for more information
using System;
using System.Reflection;
using BackendTests;
using IntroSE.Kanban.Backend.BusinessLayer;
using IntroSE.Kanban.Backend.ServiceLayer;

namespace IntroSE.Kanban.BackendTests
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Test Enviorment!");
            UserFacade userFacade = new UserFacade();
            KanbanFacade kanbanFacade = new KanbanFacade(userFacade);
            UserService userService = new UserService(userFacade);
            BoardService boardService = new BoardService(kanbanFacade);
            TaskService taskService = new TaskService(kanbanFacade);
            TestUserService testUser = new TestUserService(userService);
            TaskServiceTest testTask = new TaskServiceTest(taskService);
            BoardServiceTests testBoard = new BoardServiceTests(boardService);
            GradingService grading = new GradingService();

            grading.DeleteData();
            userService.Register("shooki@gmail.com", "aA123456");
            userService.Register("mooki@gmail.com", "bB123456");
            userService.Register("Kooki@gmail.com", "cC123456");
            userService.Login("shooki@gmail.com", "aA123456");
            userService.Login("mooki@gmail.com", "bB123456");
            userService.Login("Kooki@gmail.com", "cC123456");
            boardService.AddBoard("shooki@gmail.com", "popolopo");
            boardService.AddBoard("mooki@gmail.com", "missions");
            boardService.AddBoard("Kooki@gmail.com", "missions");
            taskService.AddTask("shooki@gmail.com", "popolopo", "task1", "", new DateTime(2024, 03, 04));
            taskService.AddTask("mooki@gmail.com", "missions", "task1", "", new DateTime(2024, 03, 04));
            taskService.AddTask("Kooki@gmail.com", "missions", "task1", "", new DateTime(2024, 03, 04));
            taskService.AddTask("Kooki@gmail.com", "missions", "task2", "", new DateTime(2024, 03, 04));
            taskService.AssignTask("Kooki@gmail.com", "missions", 0, 1, "Kooki@gmail.com");
            taskService.UpdateTaskDescription("Kooki@gmail.com", "missions", 0, 1, "same but different");
            userService.Logout("shooki@gmail.com");
            taskService.UpdateTaskDueDate("shooki@gmail.com", "popolopo", 0, 1, new DateTime(2026, 03, 04));
            userService.Login("shooki@gmail.com", "cC123456");
            taskService.UpdateTaskDueDate("shooki@gmail.com", "popolopo", 0, 1, new DateTime(2026, 03, 04));
            userService.Login("shooki@gmail.com", "aA123456");
            taskService.AssignTask("shooki@gmail.com", "popolopo", 0, 1, "shooki@gmail.com");
            taskService.UpdateTaskDueDate("shooki@gmail.com", "popolopo", 0, 1, new DateTime(2026, 03, 04));
            boardService.LimitColumnTasks("shooki@gmail.com", "popolopo", 0, 4);
            taskService.AddTask("shooki@gmail.com", "popolopo", "task2", "", new DateTime(2024, 03, 04));
            taskService.AddTask("shooki@gmail.com", "popolopo", "task3", "", new DateTime(2024, 03, 04));
            taskService.AddTask("shooki@gmail.com", "popolopo", "task4", "", new DateTime(2024, 03, 04));
            taskService.AddTask("shooki@gmail.com", "popolopo", "task5", "", new DateTime(2024, 03, 04));
            taskService.UpdateTaskDescription("shooki@gmail.com", "popolopo", 0, 1, "LordAllMighty");
            boardService.JoinBoard("Kooki@gmail.com", 1);
            boardService.TransferOwnership("shooki@gmail.com", "Kooki@gmail.com", "popolopo");
            string tasks = taskService.InProgressTasks("shooki@gmail.com");
            System.Console.WriteLine(tasks);
            boardService.AdvanceTask("shooki@gmail.com", "popolopo", 0, 4);
            boardService.AdvanceTask("Kooki@gmail.com", "popolopo", 0, 4);
            boardService.AdvanceTask("Kooki@gmail.com", "mission", 0, 1);
            boardService.AdvanceTask("shooki@gmail.com", "popolopo", 0, 1);
            tasks= taskService.InProgressTasks("shooki@gmail.com");
            System.Console.WriteLine(tasks);



            //boardService.AdvanceTask("shooki@gmail.com", "missions", 0, 1);
            //boardService.GetColumn("shooki@gmail.com", "missions", 1);

            //new BoardServiceTests(boardService).LimitColoumnTasksTest();
            //new TaskServiceTest(taskService).runAddTaskTest();
            //new BoardServiceTests(boardService).GetColoumnLimitTest();

            //userService.Login("shooki@gmail.com", "1234567");

            //new TestUserService(userService).RunRegistrationTests();

            //new BoardServiceTests(boardService).AddBoardTest();

            userService.Register("shooki@gmail.com", "A2345678i");
            userService.Register("gilb@gmail.com", "A2345678i");
            boardService.AddBoard("shooki@gmail.com", "board1");
            taskService.AddTask("shooki@gmail.com", "board1", "task1", "", new DateTime(2024, 03, 04));
            //userService.LoadUsers();
            //boardService.LoadBoards();
            //boardService.AddBoard("gilb@gmail.com", "board12");

            //boardService.DeleteBoard("gilb@gmail.com", "board12");
            //taskService.AddTask("gilb@gmail.com", "board12", "final", "test", new DateTime(2023, 08, 04));
            //boardService.JoinBoard("gilb@gmail.com", 1);
            //taskService.AssignTask("shooki@gmail.com", "board1", 0, 1, "gilb@gmail.com");
            //boardService.AdvanceTask("shooki@gmail.com", "board1", 0, 2);
            //boardService.TransferOwnership("shooki@gmail.com", "gilb@gmail.com", "board1");
            //boardService.TransferOwnership("gilb@gmail.com", "shooki@gmail.com", "board1");
            //boardService.TransferOwnership("hi", "shooki@gmail.com", "board1");
            //boardService.TransferOwnership(null, "shooki@gmail.com", "board1");
            //new BoardServiceTests(boardService).GetBoardNameTest();
            //new BoardServiceTests(boardService).GetUserBoardsTest();

            //new BoardServiceTests(boardService).DeleteBoardsTest();
            //new BoardServiceTests(boardService).LoadBoardsTest();
            // new BoardServiceTests(boardService).TransferOwnershipTest();
            //new TestUserService(userService).LoadUsersTest();
            //new TestUserService(userService).DeleteUsersTest();
            //new BoardServiceTests(boardService).LeaveBoardTest();

            //  new BoardServiceTests(boardService).GetUserBoardsTest();

            //boardService.LeaveBoard("gilb@gmail.com", 1);


            //new BoardServiceTests(boardService).GetBoardNameTest();
            //new BoardServiceTests(boardService).DeleteBoardsTest();
            // new BoardServiceTests(boardService).LoadBoardsTest();
            //new BoardServiceTests(boardService).TransferOwnershipTest();
            // new TestUserService(userService).LoadUsersTest();
            // new TestUserService(userService).DeleteUsersTest();
            // new BoardServiceTests(boardService).LeaveBoardTest();
            // new BoardServiceTests(boardService).JoinBoardTest();
            // new BoardServiceTests(boardService).GetUserBoardsTest();
            // new TaskServiceTest(taskService).AssignTaskTest();
            //new TestUserService(userService).RunRegistrationTests();
            // new BoardServiceTests(boardService).AddBoardTest();
            // new TaskServiceTest(taskService).runAddTaskTest();
            //new BoardServiceTests(boardService).LimitColoumnTasksTest();
            //new BoardServiceTests(boardService).GetColoumnLimitTest();
            //new BoardServiceTests(boardService).GetColoumnTest();
            //string s0 = boardService.GetColumn("Almogim@gmail.com", "board1", 0);
            //Console.WriteLine(s0);
            // new TaskServiceTest(taskService).runUpdateTaskTitleTest();
            //new TaskServiceTest(taskService).runUpdateTaskDescriptionTest();
            //new TaskServiceTest(taskService).runUpdateTaskDueDateTest();
            //new BoardServiceTests(boardService).LimitColoumnTasksTest();
            //new BoardServiceTests(boardService).GetColoumnLimitTest();
            //new BoardServiceTests(boardService).GetColoumnTest();
            //string s = boardService.GetColumn("Almogim@gmail.com", "board1", 0);
            //Console.WriteLine(s);
            //boardService.GetColumn("shooki@gmail.com", "missions",0);
            //string s = boardService.GetColumn("Almogim@gmail.com", "board1", 0);
            //Console.WriteLine(s);
            //new BoardServiceTests(boardService).GetColoumnTest();
            //new BoardServiceTests(boardService).AdvanceTaskTest();
            //new BoardServiceTests(boardService).GetColoumnTest();
            //new BoardServiceTests(boardService).GetColoumnTest();
            //string s1 = boardService.GetColumn("Almogim2@gmail.com", "board1", 0);
            //Console.WriteLine(s1);
            //string s2 = taskService.InProgressTasks("Almogim@gmail.com");
            //Console.WriteLine(s2);
            //new TaskServiceTest(taskService).InProgressTasksTest();
            //new BoardServiceTests(boardService).DeleteBoardTest();
            // new BoardServiceTests(boardService).GetColoumnTest();

            /**
            string s3 = boardService.GetColumn("Almogim@gmail.com", "board1", 0);
            Console.WriteLine(s3);
            **/

            /**
            new BoardServiceTests(boardService).AdvanceTaskTest();
            string s1 = boardService.GetColumn("Almogim@gmail.com", "board1", 1);
            Console.WriteLine(s1);
            string s2 = boardService.InProgressTasks("Almogim@gmail.com");
            Console.WriteLine(s2);
            **/

            //new BoardServiceTests(boardService).InProgressTasksTest();
            //string s3 = boardService.GetColumn("Almogim@gmail.com", "board1", 0);
            //Console.WriteLine(s3);
            //boardService.GetColumn("shooki@gmail.com", "missions",0);
            //new TestUserService(userService).RunRegistrationTests();
            //new TestUserService(userService).RunLoginTests();  
            //new BoardServiceTests(boardService).AddBoardTest();
            //new TestUserService(userService).LogoutTests();
            //new BoardServiceTests(boardService).DeleteBoardTest();
            //new BoardServiceTests(boardService).GetAllBoardsTest();
            //new BoardServiceTests(boardService).DeleteBoardTest();
            //new BoardServiceTests(boardService).LimitColoumnTasksTest();
            //new BoardServiceTests(boardService).AdvanceTaskTest();
            //new BoardServiceTests(boardService).InProgressTasksTest();
            //new BoardServiceTests(boardService).GetColoumnLimitTest();
            //new BoardServiceTests(boardService).GetColoumnNameTest();
            //new BoardServiceTests(boardService).GetColoumnTest();
            //new TaskServiceTest(taskService).runAddTaskTest();
            //new TaskServiceTest(taskService).runUpdateTaskDueDateTest();
            //new TaskServiceTest(taskService).runUpdateTaskTitleTest();
            //new TaskServiceTest(taskService).runUpdateTaskDescriptionTest();
            //new TaskServiceTest(taskService).runDeleteTaskTest();

        }
    }
}