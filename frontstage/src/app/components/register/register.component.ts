import { Component, OnInit } from '@angular/core';
import { ElMessageService } from 'element-angular'
import { FormControl,FormGroup,FormBuilder } from '@angular/forms';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {

  public userData: FormGroup;
  public sexlist: [
    { value: string; name: string; },
    { value: string; name: string; }
  ]
  public country: [
    { value: string; name: string; },
    { value: string; name: string; },
    { value: string; name: string; },
    { value: string; name: string; },
    { value: string; name: string; },
    { value: string; name: string; },
    { value: string; name: string; },
    { value: string; name: string; },
  ];
  constructor(
    private fb: FormBuilder,
    private message: ElMessageService
  ) { 
    this.sexlist = [
      { value: '1',name: '男', },
      { value: '2', name: '女' },
    ]
    this.userData = this.fb.group({
      account: ['', [this.accountValidator]],
      password: ['' , [this.passwordValidator]],
      name: [''],
      cellphone: ['', [this.cellphoneValidator]],
      country: [''],
      address: [''],
      sex: [''],
      birthday: [''],
      Terms: [true]
    });
    this.country = [
      {
        value:'cn',
        name: '中国(+86)'
      },
      {
        value:'cn-tw',
        name: '中国台湾(+886)'
      },
      {
        value:'cn-hg',
        name: '中国香港(+852)'
      },
      {
        value:'au',
        name: '澳大利亚(+061)'
      },
      {
        value:'usa',
        name: '美国(+001)'
      },
      {
        value:'jpn',
        name: '日本(+081)'
      },
      {
        value:'can',
        name: '加拿大(+001)'
      },
      {
        value:'kor',
        name: '韩国(+082)'
      }
    ];
  }

  statusCtrl(item: string): string {
    if (!this.userData.controls[item]) return
    const control: any = this.userData.controls[item]
    return control.dirty && control.hasError('status') ? control.errors.status : ''
  }
  
  messageCtrl(item: string): string {
    if (!this.userData.controls[item]) return
    const control: any = this.userData.controls[item]
    return control.dirty && control.hasError('message') ? control.errors.message : ''
  }

  ngOnInit(): void {
  }

  private accountValidator = (control: FormControl): any => {
    const mailReg: RegExp = /^[A-Za-z0-9]+@[a-zA-Z0-9_-]+(\.[a-zA-Z0-9_-]+)+$/
    if (!mailReg.test(control.value)) {
      return { status: 'error', message: '账号格式不正确' }
    }
    return { status: 'success' }
  }

  private passwordValidator = (control: FormControl): any => {
    if (!control.value) {
      return { status: 'error', message: '密码是必填的' }
    }
    if (control.value.length < 6) {
      return { status: 'error', message: '密码长度必须大于 6 位' }
    }
    return { status: 'success' }
  }

  private cellphoneValidator = (control: FormControl): any => {
    const mailReg: RegExp = /^[1]([3-9])[0-9]{9}$/
    if (!mailReg.test(control.value)) {
      return { status: 'error', message: '手机号格式不正确' }
    }
    return { status: 'success' }
  }

  handle(time: number): void {
    // [time] is string
    // date style follow format props
    console.log(time)
  }

  submit(type: string): void{
    this.message[type]('请联络系统管理员串接 api ');
  }

}
