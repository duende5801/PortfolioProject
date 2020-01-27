import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { RoutingWindowComponent } from './routing-window.component';

describe('RoutingWindowComponent', () => {
  let component: RoutingWindowComponent;
  let fixture: ComponentFixture<RoutingWindowComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ RoutingWindowComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(RoutingWindowComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
