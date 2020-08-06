import { AlertifyService } from './services/alertify.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
})
export class AppComponent implements OnInit {
  title = 'TrinetiumSPA';

  constructor(private alertify: AlertifyService) {}

  ngOnInit(): void {
    this.alertify.success('Hello world');
  }
}
