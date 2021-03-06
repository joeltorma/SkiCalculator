import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { __classPrivateFieldSet } from 'tslib';
import { DataService } from '../data.service';

@Component({
  selector: 'app-ski-length-calculator',
  templateUrl: './ski-length-calculator.component.html',
  styleUrls: ['./ski-length-calculator.component.css']
})
export class SkiLengthCalculatorComponent implements OnInit {
  fromLength?: number;
  toLength?: number;
  style?: string;
  selectedStyle?: string;
  height?: number;
  age?: number;
  StyleArray: any = ['classic', 'skate'];
  calculateForm: FormGroup = new FormGroup({});
  showSpinner: boolean = false;
  errorMessage?: string;
  

  //constructor(private dataService: DataService) { 
  constructor(private dataService: DataService, private formBuilder: FormBuilder) {
    }
    ngOnInit() {
      this.calculateForm = this.formBuilder.group({
        height: [null, [Validators.required, Validators.pattern('[0-9]{0,3}')]],
        age: [null, [Validators.required, Validators.pattern('[0-9]{0,3}')]],
        style: [null, Validators.required]
      })
  }

  submitCalculation() {
    this.errorMessage = '';
    this.fromLength = 0;
    this.toLength = 0;
    if (!this.calculateForm?.valid) {
      return;
    }
    this.showSpinner = true;
    this.dataService.sendGetRequest(this.calculateForm.controls['height'].value, this.calculateForm.controls['age'].value, this.calculateForm.controls['style'].value).subscribe((data: any) => {
        this.showSpinner = false;
        this.fromLength = data[0];
        this.toLength = data[1];
    }, (error) => {
      console.error('Error, server not responding with status ' + error.status);
      this.errorMessage = error;
      this.showSpinner = false;
    })
    
  }
}