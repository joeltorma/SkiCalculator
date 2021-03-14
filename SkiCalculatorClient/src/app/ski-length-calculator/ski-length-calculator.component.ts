import { Component, OnInit } from '@angular/core';
import { DataService } from '../data.service';

@Component({
  selector: 'app-ski-length-calculator',
  templateUrl: './ski-length-calculator.component.html',
  styleUrls: ['./ski-length-calculator.component.css']
})
export class SkiLengthCalculatorComponent implements OnInit {
  public lengthSpan: LengthSpan | undefined;
  selectedStyle = '';
  constructor(private dataService: DataService) { }
  public height: string = '170';
  public age: string = '30';
  public style: string = 'skate';
  ngOnInit() {
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
