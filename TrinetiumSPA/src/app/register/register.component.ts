import { Customer } from './../models/customer';
import { Component, OnInit, Output, EventEmitter } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { AlertifyService } from '../services/alertify.service';
import { AuthService } from '../services/auth.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css'],
})
export class RegisterComponent implements OnInit {
  @Output() cancelRegister = new EventEmitter();
  model: any = {};
  registerForm: FormGroup;
  customer: Customer;

  constructor(
    private router: Router,
    private authService: AuthService,
    private alertify: AlertifyService,
    private fb: FormBuilder
  ) {}

  ngOnInit(): void {
    this.createRegisterForm();
  }

  createRegisterForm(): void {
    this.registerForm = this.fb.group({
      companyName: ['', Validators.required],
      contactName: ['', Validators.required],
      contactTitle: [null, Validators.required],
      address: ['', Validators.required],
      city: ['', Validators.required],
      region: ['', Validators.required],
      country: ['', Validators.required],
      postalCode: ['', Validators.required],
      phone: [
        '',
        [
          Validators.required,
          Validators.minLength(4),
          Validators.maxLength(12),
        ],
      ],
      fax: [''],
    });
  }

  register(): void {
    this.customer = { ...this.registerForm.value };
    this.customer = Object.assign({}, this.registerForm.value);
    console.log(this.customer);
    this.authService.register(this.customer).subscribe(
      () => {
        this.alertify.success('Register successful');
      },
      (error) => {
        this.alertify.error(error);
      },
      () => {
        this.authService.login(this.customer).subscribe(() => {
          this.router.navigate(['/member']);
        });
      }
    );
  }

  cancel(): void {
    this.cancelRegister.emit(false);
    this.alertify.message('cancel');
  }
}
