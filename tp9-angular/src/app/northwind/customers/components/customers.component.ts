import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { Customers } from '../models/customers';
import { ServiceNorthwind } from '../services/northwind.service';

@Component({
  selector: 'app-component-customers',
  templateUrl: './customers.component.html',
  styleUrls: ['./customers.component.sass']
})
export class AppComponentCustomers implements OnInit{

  customers: Array<Customers>=[];
  elementToEdit :Customers;

  constructor(private _serviceNorthwind: ServiceNorthwind,private toastr: ToastrService){
  }

  ngOnInit(){
    this.getAllCustomers();
  }

  edit(id : string){
    this._serviceNorthwind.getById(id).subscribe(res=>{
      this.elementToEdit=res;
    })
  }

  delete(id:string){
    this._serviceNorthwind.delete(id).subscribe(
      ()=>{
        this.toastr.success('Los datos se borraron con exito');
        this.getAllCustomers();
    },
    err => {      
      this.toastr.error(`Oops!! Hubo un error: Consulte: Error: ${err.status}, Mensaje: ${err.error.Message}`)
    });
  }
  
  getAllCustomers(){
    this._serviceNorthwind.getAll().subscribe(
      res=>{
        if(res!=null){
            this.customers=res;
        }
      },
      err => {
        // alert(`Oops!!, Hubo un error en la conexion para traer los datos: Status error: ${err.status}, Mensaje: ${err.statusText}`)
        this.toastr.error(`Oops!! Hubo un error: Consulte: Error: ${err.status}, Mensaje: ${err.error.Message}`)
      })
  }

  changedForm(changed){
    if(changed){
      this.getAllCustomers();
    }
  }


}
