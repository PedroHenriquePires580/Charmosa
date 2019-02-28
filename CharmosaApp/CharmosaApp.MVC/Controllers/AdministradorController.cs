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

        // GET: Administrador/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Administrador/CadastrarFuncionario
        [HttpGet]
        public ActionResult CadastrarFuncionario()
        {
            ViewBag.UsuarioFuncao = new SelectList(Enum.GetValues(typeof(UsuarioFuncao)), UsuarioFuncao.Administrador);

            return View();
        }
        // POST: Administrador/CadastrarFuncionario
        [HttpPost]
        public ActionResult CadastrarFuncionario(FuncionarioViewModel funcionarioViewModel)
        {
            if (ModelState.IsValid)
            {
                FuncionarioAppService appService =
                    new FuncionarioAppService(new CharmosaAppContext(new DbContextOptions<CharmosaAppContext>()));
                var funcionario = Mapper.Map<FuncionarioViewModel, Funcionario>(funcionarioViewModel);
                appService._funcionarioUnitOfWork.FuncionarioRepository.Add(funcionario);
                appService._funcionarioUnitOfWork.Commit();

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
                    new AdministradorAppService(new UnitOfWork<Administrador>(dbContext));
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