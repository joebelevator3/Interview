import {
  Button,
  Container,
  createStyles,
  Divider,
  Flex,
  Group,
  Text,
} from "@mantine/core";

export interface ExerciseCounterData {
  /**  */
  id: number;

  /**  */
  startingValue: number;

  /**  */
  name: string;
}

const counterData: ExerciseCounterData[] = [
  { id: 1, startingValue: 0, name: "Counter α" },
  { id: 2, startingValue: 3, name: "Counter β" },
  { id: 3, startingValue: 100, name: "Counter γ" },
];
export const CountersExercise = () => {
  return (
    <Container>
      <div>
        <h1>Counter Data</h1>
        <div className="counter-label">Counter α: 0</div>
        <Group>
          <Button>+</Button>
          <Button>-</Button>
        </Group>
      </div>
    </Container>
  );
};
