import { TestBed } from '@angular/core/testing';
import { AppComponentCustomers } from './customers.component';

describe('AppComponentCustomers', () => {
  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [
        
      ],
      declarations: [
        AppComponentCustomers
      ],
    }).compileComponents();
  });

  it('should create the app', () => {
    const fixture = TestBed.createComponent(AppComponentCustomers);
    const app = fixture.componentInstance;
    expect(app).toBeTruthy();
  });

  // it(`should have as title 'tp9-angular'`, () => {
  //   const fixture = TestBed.createComponent(AppComponentCustomers);
  //   const app = fixture.componentInstance;
  //   expect(app.title).toEqual('tp9-angular');
  // });

  it('should render title', () => {
    const fixture = TestBed.createComponent(AppComponentCustomers);
    fixture.detectChanges();
    const compiled = fixture.nativeElement;
    expect(compiled.querySelector('.content span').textContent).toContain('tp9-angular app is running!');
  });
});
