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
  public lengthSpan: LengthSpan | undefined;
  style = '';
  selectedStyle = '';
  height: number = 0;
  age: number = 0;
  StyleArray: any = ['classic', 'skate'];
  calculateForm: FormGroup = new FormGroup({});

  //constructor(private dataService: DataService) { 
  constructor(private dataService: DataService, private formBuilder: FormBuilder) {
    }
    ngOnInit() {
      this.calculateForm = this.formBuilder.group({
        height: [null, [Validators.required, Validators.pattern("[0-9]{0,3}")]],
        age: [null, [Validators.required, Validators.pattern("[0-9]{0,3}")]],
        style: [null, Validators.required]
      })
  }

  submitCalculation() {
    if (!this.calculateForm?.valid) {
      return;
    }
    console.log(this.calculateForm.value)
    this.dataService.sendGetRequest(this.height, this.age, this.style).subscribe((data: any) => {
        console.log(data);
        this.lengthSpan = data;
    })
  }

}

interface LengthSpan {
  fromLength: number;
  toLength: number;
}
