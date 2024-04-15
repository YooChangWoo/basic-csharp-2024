// 파이썬용 라이브러리 사용등록
using IronPython.Hosting;
using static System.Net.Mime.MediaTypeNames;
using System;

namespace ex15_pythons
{
    /*
     * 'C:\\Users\\ckddn\\AppData\\Roaming\\Python\\Python311\\site-packages',
     * 'C:\\Users\\ckddn\\AppData\\Roaming\\Python\\Python311\\site-packages\\win32',
     * 'C:\\Users\\ckddn\\AppData\\Roaming\\Python\\Python311\\site-packages\\win32\\lib',
     * 'C:\\Users\\ckddn\\AppData\\Roaming\\Python\\Python311\\site-packages\\Pythonwin',
     * 'C:\\DEV\\Langs\\Python311\\Lib\\site-packages']
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("파이썬 실행예제.");

            var engine = Python.CreateEngine();
            var scope = engine.CreateScope();
            var paths = engine.GetSearchPaths();

            // Python 경로 설정 @(리소스 키워드)
            paths.Add(@"C:\\DEV\\Langs\\Python311"); // 기본 파이썬 경로
            paths.Add(@"C:\\DEV\\Langs\\Python311\DLLs"); 
            paths.Add(@"C:\\DEV\\Langs\\Python311\Lib"); 
            paths.Add(@"C:\\DEV\\Langs\\Python311\Lib\site-packages");

            paths.Add(@"C:\\Users\\ckddn\\AppData\\Roaming\\Python\\Python311\\site-packages");
            paths.Add(@"C:\\Users\\ckddn\\AppData\\Roaming\\Python\\Python311\\site-packages\\win32");
            paths.Add(@"C:\\Users\\ckddn\\AppData\\Roaming\\Python\\Python311\\site-packages\\win32\\lib");
            paths.Add(@"C:\\Users\\ckddn\\AppData\\Roaming\\Python\\Python311\\site-packages\\Pythonwin");

            // 실행시킬 Python 파일 경로 설정
            var filePath = @"C:\sources\basic-csharp-2024\day03\ex12_lambdas\ex15_pythons\Test.py";
            var source = engine.CreateScriptSourceFromFile(filePath);

            // Python 실행
            source.Execute(scope);

            var PythonFunc = scope.GetVariable<Func<int, int, int>>("sum");
            var result = PythonFunc(10, 7);
            Console.WriteLine($"Python 함수실행 = {result}");

            var PythonGreeting = scope.GetVariable<Func<string>>("sayGreeting");
            var greeting = PythonGreeting();
            Console.WriteLine($"결과 = {greeting}");
        }
    }
}
