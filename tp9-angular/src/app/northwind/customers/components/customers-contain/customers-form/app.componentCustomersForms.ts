import { Component, Input, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Customers } from '../../../models/customers';
import { ServiceNorthwind } from '../../../services/service_northwind.service';
import { Router } from '@angular/router'

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
    }

  }

  get f(){ return this.uploadForm.controls;}

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

  editElement(cust:Customers) :void{
    this.uploadForm.controls['CustomerID'].setValue(cust.CustomerID ? cust.CustomerID : '');
    this.uploadForm.controls['CompanyName'].setValue(cust.CompanyName ? cust.CompanyName : '')
    this.uploadForm.controls['ContactName'].setValue(cust.ContactName ? cust.ContactName : '')
    this.uploadForm.controls['Country'].setValue(cust.Country ? cust.Country : '')
    window.scrollTo(0,0);
    this.actionBtnFormEditar=true;
  }
}
