import { Component, Input, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Customers } from '../../../models/customers';
import { ServiceNorthwind } from '../../../services/service_northwind.service';
import { Router } from '@angular/router'
import { Observable, Observer } from 'rxjs';

@Component({
  selector: 'app-component-customers-forms',
  templateUrl: './app.componentCustomersForms.html',
  styleUrls: ['./app.componentCustomersForms.sass']
})

export class AppComponentCustomersForms implements OnInit{

  @Input() elementToEdit: Customers;
  uploadForm: FormGroup;
  actionBtnFormEditar: boolean=false;
  customer:Customers;
  msj_to_usurio :string=null;
  myObserver_msj:Observer <any> ={
    next: actionBtnFormEditar => {
      if(actionBtnFormEditar){
       this. msj_to_usurio="Edite"
      }else{
        this. msj_to_usurio="Ingrese"
      }
    },
    error: function (err: any): void {
      throw new Error('Function not implemented.');
    },
    complete: function (): void {
      throw new Error('Function not implemented.');
    }
  }
  myObservable_msj=new Observable(suscriber =>{
    suscriber.next(this.actionBtnFormEditar);
  })


  constructor( private formBuilder:FormBuilder, private _serviceNorthwind: ServiceNorthwind, private router:Router){

    this.uploadForm=this.formBuilder.group({
      CustomerID:[''],
      CompanyName:['', [Validators.required, Validators.maxLength(15), Validators.minLength(3)]],
      ContactName:['', [Validators.required, Validators.maxLength(15), Validators.minLength(3)]],
      Country:['', [Validators.required, Validators.maxLength(10), Validators.minLength(3)]]

    })
  }

  ngOnInit(): void {

  }

  ngOnChanges(): void {
    if(this.elementToEdit!=null){
      this.editElement(this.elementToEdit);
      this.actionBtnFormEditar=true;
      this.myObservable_msj.subscribe(this.myObserver_msj)
    }
  }

  get f(){ return this.uploadForm.controls;}

  clean(){
    this.uploadForm.reset();
    this.actionBtnFormEditar=false;
      this.myObservable_msj.subscribe(this.myObserver_msj)
  }

  editElement(cust:Customers) :void{
    this.uploadForm.controls['CustomerID'].setValue(cust.CustomerID ? cust.CustomerID : '');
    this.uploadForm.controls['CompanyName'].setValue(cust.CompanyName ? cust.CompanyName : '')
    this.uploadForm.controls['ContactName'].setValue(cust.ContactName ? cust.ContactName : '')
    this.uploadForm.controls['Country'].setValue(cust.Country ? cust.Country : '')
    window.scrollTo(0,0);
  }

  submitted=false;
  onSubmit():void{
    this.submitted=true;
    if(this.uploadForm.invalid){
      alert("Los campos, no pueden estar vacios y tienen un maximo de 10 caracteres.")
      return;
    }else{

      if(this.actionBtnFormEditar){
        this.customer=this.uploadForm.value;
        console.log("aca", this.customer)
        this._serviceNorthwind.Put(this.customer).subscribe(res => {
          if(res=="OK"){
            window.location.reload()
            alert("Ok!! Los datos se editaron bien...")
          }else{
            window.location.reload()
            alert("Ups!! Hubo un error, consulte...")
          }
        });
        this.actionBtnFormEditar=false;
      }else{
        this.customer=this.uploadForm.value;
        this._serviceNorthwind.Post(this.customer).subscribe(res => {
          if(res=="OK"){
            window.location.reload()
            alert("Ok!! Los datos se ingresaron bien...")
          }else{
            window.location.reload()
            alert("Ups!! Hubo un error, consulte...")
          }
        });;
      }
      
    }

  }

  
}
