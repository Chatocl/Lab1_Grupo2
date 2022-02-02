﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Lab1_Grupo2.Models.Datos;

namespace Lab1_Grupo2.Controllers
{
    public class ClientesController : Controller
    {
        // GET: ClientesController
        public ActionResult Index()
        {
            return View(Singleton.Instance.ClientesList);
        }

        // GET: ClientesController/Details/5
        public ActionResult Details(int id)
        {
            var ViewStudent = Singleton.Instance.ClientesList.Find(x => x.Id == id);
            return View(ViewStudent);
        }

        // GET: ClientesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ClientesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                var NewCliente = new Models.Clientes
                {
                    Id = Convert.ToInt32(collection["Id"]), 
                    Nombre_CL = collection["Nombre"], Apellido_CL = collection["Apellido"],
                    Descripcion_CL = collection["Descripción"], 
                    Telefono_CL=Convert.ToInt32(collection["Telefono"])
                };
                Singleton.Instance.ClientesList.Add(NewCliente);
                return RedirectToAction(nameof(Index));

            }
            catch
            {
                return View();
            }
        }

        // GET: ClientesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ClientesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClientesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ClientesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}