import { Component, OnInit, ViewEncapsulation } from '@angular/core';
import {SelectItem} from 'primeng/api';

interface Project {
  name: string;
  code: string;
}

@Component({
  selector: 'app-left-panel',
  templateUrl: './left-panel.component.html',
  styleUrls: ['./left-panel.component.scss'],
  encapsulation: ViewEncapsulation.None,
})
export class LeftPanelComponent implements OnInit {
  projects1: SelectItem[];

  selectedProject: Project;

  constructor() { 
    this.projects1 = [
      {label:'Trivia', value:{id:1, name: 'Trivia Goonie', code: 'TG'}},
      {label:'Weather', value:{id:2, name: 'Weather API', code: 'WA'}},
      {label:'ToDo', value:{id:3, name: 'ToDo List', code: 'TL'}},
      {label:'Prototype Recreation 1', value:{id:4, name: 'Hamster Hotel', code: 'HH'}},
      {label:'Prototype Recreation 2', value:{id:4, name: 'Puppy Restraunt', code: 'PR'}},
      {label:'Buisness Redevelopment', value:{id:5, name: 'Michaels Pizza Website', code: 'MPW'}},
      {label:'Caluculator', value:{id:6, name: 'Calculator and Conversions', code: 'CNC'}},
      {label:'Deal Or No Deal', value:{id:7, name: 'Deal or No Deal', code: 'DND'}},
      {label:'CodeStack Directory', value:{id:8, name: 'CodeStack Directory', code: 'CD'}},
      {label:'Multi-Page Site', value:{id:9, name: 'Top Games Site', code: 'TGS'}}
  ];
  }

  ngOnInit() {
  }

}
