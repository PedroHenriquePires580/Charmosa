using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CharmosaApp.Application;
using CharmosaApp.Application.Interfaces;
using CharmosaApp.Infra.Data.Contexto;
using CharmosaApp.Infra.Data.UnitOfWork;
using CharmosaApp.MVC.ViewModels;
using CharmosaAPP.Domain.Entities;
using CharmosaAPP.Domain.Entities.Enumeradores;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace CharmosaApp.MVC.Controllers
{
    public class AdministradorController : Controller
    {
        // GET: Administrador
        public ActionResult Index()
        {
            return View();
        }

        // GET: Administrador/DetalhesFuncionario/5
        [HttpGet]
        public ActionResult DetalhesFuncionario(int id)
        {
            FuncionarioAppService appService
                = new FuncionarioAppService(new CharmosaAppContext(new DbContextOptions<CharmosaAppContext>()));

            Funcionario funcionario = appService._funcionarioUnitOfWork.FuncionarioRepository.GetByID(id);
            var funcionarioView = Mapper.Map<FuncionarioViewModel>(funcionario);

            return View(funcionarioView);
        }

        // GET: Administrador/CadastrarUsuario
        [HttpGet]
        public ActionResult CadastrarUsuario()
        {
            ViewBag.UsuarioFuncao = new SelectList(Enum.GetValues(typeof(UsuarioFuncao)), UsuarioFuncao.Funcionario);

            return View();
        }
        // POST: Administrador/CadastrarFuncionario
        [HttpPost]
        public ActionResult CadastrarUsuario(FuncionarioViewModel funcionarioViewModel)
        {
            if (ModelState.IsValid)
            {
                FuncionarioAppService appService =
                    new FuncionarioAppService(new CharmosaAppContext(new DbContextOptions<CharmosaAppContext>()));
                var funcionario = Mapper.Map<Funcionario>(funcionarioViewModel);
                appService._funcionarioUnitOfWork.FuncionarioRepository.Add(funcionario);
                appService._funcionarioUnitOfWork.Commit();
                return RedirectToAction(nameof(DetalhesFuncionario), new { id = funcionario.FuncionarioID });
            }

            return View();
        }

        // POST: Administrador/Create
        [HttpPost]
        public ActionResult Create(AdministradorViewModel model)
        {
            try
            {
                //// TODO: Add insert logic here
                CharmosaAppContext dbContext = new CharmosaAppContext(new DbContextOptions<CharmosaAppContext>());
                AdministradorAppService appService =
                    new AdministradorAppService(dbContext);
                appService._administradorUnitOfWork.AdministradorRepository.Add(new Administrador());

                return View();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return View();
            }
        }

        // GET: Administrador/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Administrador/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Administrador/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Administrador/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}