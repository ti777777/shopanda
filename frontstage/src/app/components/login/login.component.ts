import { Component, OnInit } from '@angular/core';
import { FormControl,FormBuilder,FormGroup } from '@angular/forms';
import { ElMessageService } from 'element-angular'

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  public validateForm: FormGroup;
  constructor(
    private formBuilder: FormBuilder,
    private message: ElMessageService
  ) { 
  }

  ngOnInit(): void {
    this.validateForm = this.formBuilder.group({
      password: [ '', [] ],
      mail: [ '', [] ],
    })
  }

 

  submit(type: string): void {
    this.message[type]('发生错误 ~ 联络系统管理员 ！！(未提交 api )')
  }

  

  reset(): void {
    this.validateForm.reset()
  }


}
