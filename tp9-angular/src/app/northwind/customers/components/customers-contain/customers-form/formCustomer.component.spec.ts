import { TestBed } from '@angular/core/testing';
import { AppComponentCustomersForms } from './formCustomer.component';

describe('AppComponentCustomers', () => {
  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [
        
      ],
      declarations: [
        AppComponentCustomersForms
      ],
    }).compileComponents();
  });

  it('should create the app', () => {
    const fixture = TestBed.createComponent(AppComponentCustomersForms);
    const app = fixture.componentInstance;
    expect(app).toBeTruthy();
  });

  // it(`should have as title 'tp9-angular'`, () => {
  //   const fixture = TestBed.createComponent(AppComponentCustomersForms);
  //   const app = fixture.componentInstance;
  //   expect(app.title).toEqual('tp9-angular');
  // });

  it('should render title', () => {
    const fixture = TestBed.createComponent(AppComponentCustomersForms);
    fixture.detectChanges();
    const compiled = fixture.nativeElement;
    expect(compiled.querySelector('.content span').textContent).toContain('tp9-angular app is running!');
  });
});
