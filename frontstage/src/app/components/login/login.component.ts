import { Component, OnInit } from '@angular/core';
import { FormControl,FormBuilder,FormGroup } from '@angular/forms';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  public validateForm: FormGroup;
  constructor(
    private formBuilder: FormBuilder
  ) { 
  }

  ngOnInit(): void {
    this.validateForm = this.formBuilder.group({
      password: [ '', [] ],
      mail: [ '', [] ],
    })
  }

 

  submit(): void {
    console.log(this.validateForm.value)
  }

  reset(): void {
    this.validateForm.reset()
  }


}
