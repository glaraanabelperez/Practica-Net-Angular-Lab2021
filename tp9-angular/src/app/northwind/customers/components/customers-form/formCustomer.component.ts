import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Customers } from '../../models/customers';
import { ServiceNorthwind } from '../../services/northwind.service';


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

  constructor( private formBuilder:FormBuilder, private _serviceNorthwind: ServiceNorthwind){
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
    //alpedo esto
    if(this.elementToEdit!=null){
      this.setEditElement(this.elementToEdit);
      this.enableEditing=true;
      this.msj_edit="Edite"
    }
    this.msj_edit=this.enableEditing==true ? "Edite" : "Ingrese";
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
    if(this.uploadForm.invalid){
        return;
      }
    if(this.enableEditing){
         this.edit();            
     }else{
         this.insert();
     }
     this.submitted=false;
     this.cleanForm();
  }

  insert(){
    this.customer=this.uploadForm.value;
    console.log(this.customer)
    this._serviceNorthwind.post(this.customer).subscribe(
        () => {
          this.changedTheForm.emit(true);
            alert("Ok!! Los datos se ingresaron bien...")
          },
      (err) => {
            console.log(err, err.error)
            window.location.reload()
            alert(`Oops!! Hubo un error, consulte: Status error: ${err.status}, Mensaje: ${err.error.Message}`);
          })
  }

  edit(){
    this.enableEditing=false;
    this.customer=this.uploadForm.value;
    //mapear a mano
    this._serviceNorthwind.put(this.customer).subscribe(
      () => {
        this.changedTheForm.emit(true);
         alert("Ok!! Los datos se editaron bien...")
      },
      (err) => {
        alert(`Oops!! Hubo un error, consulte: Status error: ${err.status}, Mensaje: ${err.error.Message}`);
      })     
    
  }
  // mapeoCustomerForm(){
  //   this.customer.CustomerID= this.uploadForm.controls['CustomerID']
  //   this.customer.CompanyName= this.uploadForm.controls['CompanyName']

  // }

}

