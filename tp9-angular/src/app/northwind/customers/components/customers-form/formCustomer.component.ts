import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Customers } from '../../models/customers';
import { ServiceNorthwind } from '../../services/northwind.service';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-component-customers-forms',
  templateUrl: './formCustomer.component.html',
  styleUrls: ['./formCustomer.component.sass']
})

export class AppComponentCustomersForms implements OnInit{

  @Input() elementToEdit: Customers;
  @Output() changedTheForm= new EventEmitter<boolean>();

  customer: Customers;
  uploadForm: FormGroup;
  enableEditing: boolean=false;
  msj_edit:string;
  submitted=false;

  constructor( private formBuilder:FormBuilder, private _serviceNorthwind: ServiceNorthwind,private toastr: ToastrService){
    this.msj_edit="Ingrese";
  }

  ngOnInit(): void {
    this.uploadForm=this.formBuilder.group({
      CustomerID:[''],
      CompanyName:['', [Validators.required, Validators.maxLength(35), Validators.minLength(2)]],
      ContactName:['', [Validators.required, Validators.maxLength(25), Validators.minLength(2)]],
      Country:['', [Validators.required, Validators.maxLength(20), Validators.minLength(2)]]
    })
  }

  ngOnChanges(): void {
    if(this.elementToEdit!=null){
      this.setEditElement(this.elementToEdit);
      this.enableEditing=true;
      this.msj_edit="Edite"
    }
  }

  get f(){ return this.uploadForm.controls;}

  cleanForm(){
    this.uploadForm.reset();
    this.enableEditing=false;
  }

  setEditElement(cust:Customers) :void{
    this.uploadForm.controls['CustomerID'].setValue(cust.CustomerID ? cust.CustomerID : '');
    this.uploadForm.controls['CompanyName'].setValue(cust.CompanyName ? cust.CompanyName : '')
    this.uploadForm.controls['ContactName'].setValue(cust.ContactName ? cust.ContactName : '')
    this.uploadForm.controls['Country'].setValue(cust.Country ? cust.Country : '')
    window.scrollTo(0,0);
  }

  onSubmit():void{
    this.submitted=true;
    if(this.enableEditing){
         this.edit();            
     }else{
         this.insert();
     }
     this.submitted=false;
     this.msj_edit="Ingrese"
     this.cleanForm();
  }

  insert(){
    this.mapeoCustomerForm();
    this._serviceNorthwind.post(this.customer).subscribe(
        () => {
          this.changedTheForm.emit(true);
          this.toastr.success('Los datos se insertaron con exito');
          },
      (err) => {
          this.toastr.error(`Oops!! Hubo un error: Consulte: Error: ${err.status}, Mensaje: ${err.error.Message}`)
          })
  }

  edit(){
    this.mapeoCustomerForm();
    this._serviceNorthwind.put(this.customer).subscribe(
      () => {
        this.changedTheForm.emit(true);
        this.toastr.success('Los datos se editaron con exito');
      },
      (err) => {
        this.toastr.error(`Oops!! Hubo un error: Consulte: Error: ${err.status}, Mensaje: ${err.error.Message}`)
      })     
    this.enableEditing=false;
  }

  mapeoCustomerForm(){
    this.customer={
      CustomerID: this.uploadForm.get('CustomerID').value,
      CompanyName: this.uploadForm.get('CompanyName').value,
      ContactName: this.uploadForm.get('ContactName').value,
      Country: this.uploadForm.get('Country').value
    };
  }

}

